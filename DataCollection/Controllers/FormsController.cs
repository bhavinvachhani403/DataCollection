﻿using DataAccess.Entity;
using DataAccess.Repository;
using DataCollection.ManageSession;
using DataCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataCollection.FormService;
using Newtonsoft.Json.Linq;
using DataCollection.Security;
using DataAccess.Enum;

namespace DataCollection.Controllers
{
    [Authorize]
    public class FormsController : Controller
    {
        //
        // GET: /Forms/
        public ActionResult Index()
        {
            return View();
        }

        #region Common Methods
        public ActionResult OnDAtaCaptYMChange(int DataCaptYM, string Menu)
        {
            FormsViewModel dOAA1ViewModel = new FormsViewModel();
            SessionManager.DataCaptYR = DataCaptYM;
            dOAA1ViewModel.GetDOAA1Data(DataCaptYM, Menu);
            string MenuPartial = FormCommonMethods.GetMenuPartial(Menu);
            object DataObject = FormCommonMethods.GetDynamicViewModel(Menu, dOAA1ViewModel);
            return PartialView(MenuPartial, DataObject);
        }

        [HttpPost]
        public ActionResult SaveUpdateFormData(CommonSaveUpdateProp data)
        {
            FormsViewModel formsViewModel = new FormsViewModel();
            object objectData = data.formData;
            string action = data.action;
            string menu = data.menu;
            bool IsSuccess = formsViewModel.SaveUpdateFormData(objectData, action, menu);
            TempData["isSaveSuccessfully"] = IsSuccess;
            return Json(new { status = IsSuccess }, JsonRequestBehavior.AllowGet);
        }
        #endregion Common Methods

        #region  DOAA Form      
        [CustomAuthorize(EntityName = Menu.DOAA)]
        public ActionResult DOAAForm(string DataCaptYM)
        {
            FormsViewModel dOAA1ViewModel = new FormsViewModel();
            int dataCaptYM = 0;
            int.TryParse(DataCaptYM, out dataCaptYM);
            dOAA1ViewModel.GetDOAA1Data(dataCaptYM, DataAccess.Enum.Menu.DOAA.ToString());
            return View(dOAA1ViewModel);
        }
        #endregion DOAA Form

        #region  Lib Form
        [CustomAuthorize(EntityName = Menu.LIBFORM)]
        public ActionResult LIBForm(string DataCaptYM)
        {
            FormsViewModel dOAA1ViewModel = new FormsViewModel();
            int dataCaptYM = 0;
            int.TryParse(DataCaptYM, out dataCaptYM);
            dOAA1ViewModel.GetDOAA1Data(dataCaptYM, DataAccess.Enum.Menu.LIBFORM.ToString());
            return View(dOAA1ViewModel);
        }
        #endregion Lib Form

        #region ADIR Form
        [CustomAuthorize(EntityName = Menu.ADIR)]
        public ActionResult ADIRForm(string DataCaptYM)
        {
            FormsViewModel dOAA1ViewModel = new FormsViewModel();
            int dataCaptYM = 0;
            int.TryParse(DataCaptYM, out dataCaptYM);
            dOAA1ViewModel.GetDOAA1Data(dataCaptYM, DataAccess.Enum.Menu.ADIR.ToString());
            return View(dOAA1ViewModel);
        }
        #endregion ADIR Form

        #region DOSW Form
        [CustomAuthorize(EntityName = Menu.DOSW)]
        public ActionResult DOSWForm(string DataCaptYM)
        {
            FormsViewModel dOAA1ViewModel = new FormsViewModel();
            int dataCaptYM = 0;
            int.TryParse(DataCaptYM, out dataCaptYM);
            dOAA1ViewModel.GetDOAA1Data(dataCaptYM, DataAccess.Enum.Menu.DOSW.ToString());
            return View(dOAA1ViewModel);
        }
        #endregion DOSW Form
    }
}