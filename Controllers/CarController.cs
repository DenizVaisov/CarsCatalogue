﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarsCatalogue.Contracts;
using CarsCatalogue.Models;
using CarsCatalogue.Models.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace CarsCatalogue.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        
        public CarController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            //CODEREV: try-catch который делает то, что уже и так делает asp.net в режиме релиза, а в режиме дебага скрывает вам реально происходящие эксепшны. Такой блок лишний. Если вам нужно обрабатывать исключение, которое выкинуло бы ошибку 500, но при это делать еще вещи в catch блоке (например закрывать открытые файлы) - тогда используйте его, делайте все нужные вещи и вконце снова выкидывайте то исключение, которе произошло, чтобы оно было поймано в asp.net. То же относится к жругим экшнам
            try 
            { 
                var cars = _repository.Car.GetAllCars();
                Console.WriteLine(cars);
                var carsResult = _mapper.Map<IEnumerable<CarDto>>(cars);
                return Ok(carsResult); 
            } 
            catch (Exception ex) 
            { 
                return StatusCode(500, "Internal server error"); 
            } 
        }
        
        [HttpGet("{id}", Name = "CarById")]
        public IActionResult GetCarById(Guid id)
        {
            try
            {
                var car = _repository.Car.GetCarById(id);
                //CODEREV: Это удобно заменить тернарным оператором
                if (car == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(car);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpPost]
        public IActionResult CreateCar([FromBody]CarForCreationDto car)
        {
            try
            {
                if (car == null)
                {
                    return BadRequest("Car object is null");
                }
                //CODEREV: Это свойство работает разве с фронтом в виде веб приложения? По-моему оно должно работать только при связывании с Razor View.
                if (!ModelState.IsValid)
                {
                    Console.WriteLine(BadRequest("Invalid model object"));
                    return BadRequest("Invalid model object");
                }

                var carEntity = _mapper.Map<Car>(car);

                _repository.Car.CreateCar(carEntity);
                _repository.Save();

                var createdCar = _mapper.Map<CarDto>(carEntity);
                Console.WriteLine(carEntity + " " + createdCar);
                return CreatedAtRoute("CarById", new {id = createdCar.id}, createdCar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateCar(Guid id, [FromBody]CarForUpdateDto car)
        {
            try
            {
                if (car == null)
                {
                    return BadRequest("Car object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var carEntity = _repository.Car.GetCarById(id);
                if (carEntity == null)
                {
                    return NotFound();
                }

                _mapper.Map(car, carEntity);

                _repository.Car.UpdateCar(carEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCar(Guid id)
        {
            try
            {
                var car = _repository.Car.GetCarById(id);
                if (car == null)
                {
                    return NotFound();
                }

                _repository.Car.DeleteCar(car);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}