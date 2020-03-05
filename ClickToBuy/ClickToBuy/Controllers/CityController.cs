﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClickToBuy.Manager.Contracts;
using ClickToBuy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClickToBuy.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityManager _iCityManager;
        private readonly ICountryManager _iCountryManager;

        public CityController(ICityManager iCityManager, ICountryManager iCountryManager)
        {
            _iCityManager = iCityManager;
            _iCountryManager = iCountryManager;
        }

        private List<SelectListItem> CountryList()
        {
            List<SelectListItem> countryList = _iCountryManager.GetAll()
                                               .Select(c => new SelectListItem
                                               {
                                                   Value = c.Id.ToString(),
                                                   Text = c.Name
                                               }).ToList();
            return countryList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_iCityManager.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryList = CountryList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isAdd = _iCityManager.Add(aCity);

                if (isAdd)
                    return RedirectToAction("Index");
                else
                    return ViewBag.ErrorMessage = "City save has been failed!";
            }

            ViewBag.CountryList = CountryList();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            City aCity = _iCityManager.GetById(id);

            if (aCity == null)
                return NotFound();

            ViewBag.CountryList = CountryList();
            return View(aCity);
        }

        [HttpPost]
        public IActionResult Update(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _iCityManager.Update(aCity);

                if (isUpdate)
                    return RedirectToAction("Index");
                else
                    return ViewBag.ErrorMessage = "City update has been failed!";
            }

            ViewBag.CountryList = CountryList();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Remove(int? id)
        {
            if (id == null)
                return NotFound();

            City aCity = _iCityManager.GetAll().Where(c => c.Id == id).FirstOrDefault();

            if (aCity == null)
                return NotFound();

            ViewBag.CountryList = CountryList();
            return View(aCity);
        }

        [HttpPost]
        public IActionResult Remove(City aCity)
        {
            bool isDelete = _iCityManager.Remove(aCity);

            if (isDelete)
                return RedirectToAction("Index");
            else
                return ViewBag.ErrorMessage = "City delete has been failed!";
        }
    }
}