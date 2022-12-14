using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Core;
using Core.ApiModel.Request;
using Core.DTO;
using SensorApi.Models;
using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensorApi.Interfaces;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorApi.Controllers
{
    [Authorize]
    [Route("api/device")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceMeasureService _DeviceMeasureService;
        private readonly IMotorService _MotorService;
        private readonly IDeviceService _DeviceService;
        private readonly IJwtAuth _jwtAuth;
        private readonly IMapper _mapper;


        private readonly IMachineService _MachineService;
        private readonly IFixationTypeService _FixationService;
        private readonly ICouplingTypeService _CouplingService;
        private readonly ICardanShaftTypeService _CardanShaftTypeService;
        private readonly IPumpTypeService _PumpTypeService;
        private readonly ICompressorTypeService _CompressorTypeService;
        //private readonly ILogger<DeviceController> _logger;

        /// <summary>
        /// Construtor
        /// </summary>        
        public DeviceController(IDeviceMeasureService DeviceMeasureService, IMotorService MotorService, IDeviceService DeviceService, IJwtAuth jwtAuth, IMapper mapper, 
            IMachineService MachineService, IFixationTypeService FixationService, ICouplingTypeService CouplingService,
            ICardanShaftTypeService CardanShaftTypeService, IPumpTypeService PumpTypeService, ICompressorTypeService CompressorTypeService)
        {
            _DeviceMeasureService = DeviceMeasureService;
            _MotorService = MotorService;
            _DeviceService = DeviceService;
            _jwtAuth = jwtAuth;
            _mapper = mapper;
            _MachineService = MachineService;
            _FixationService = FixationService;
            _CouplingService = CouplingService;
            _CardanShaftTypeService = CardanShaftTypeService;
            _PumpTypeService = PumpTypeService;
            _CompressorTypeService = CompressorTypeService;
          //  _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        [Produces("application/json")]
        public ContentResult Get()
        {

            //_logger.LogInformation($"Acesso ok");

            string respJson = "{\"Status\":\"Active\",\"Connection\":\"Ok\"}";
            ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
            return contRes1;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("deviceMeasure")]
        public ContentResult AddDeviceMeasure([FromBody] DeviceRequest devicemeasure)
        {
            string respJson = string.Empty;

            if (devicemeasure == null)
            {
                respJson = "{\"Erro Interno\":\"Erro na leitura dos dados recebidos - Estrutura vazia\"}";
                ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
                contRes1.StatusCode = (int)HttpStatusCode.InternalServerError;
                return contRes1;
            }

            //Faz busca do Motor para salvar informaões no Measure
            //var getDevice = _MotorService.GetBymotorTag(devicemeasure.T);

            var getDevice = _DeviceService.GetByDeviceTag(devicemeasure.T);
            if (getDevice == null)
            {
                respJson = "{\"Erro\":\"Tag do Sensor não encontrado no cadastro\"}";
                ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
                contRes1.StatusCode = (int)HttpStatusCode.InternalServerError;
                return contRes1;
            }

            DeviceMeasure deviMes = new DeviceMeasure
            {
                //MotorId = getDevice.Id,
                DeviceId = getDevice.Id,
                Temperature = devicemeasure.E, //Temperature
                ReadDataType = devicemeasure.R, //Tipo de Leitura 
                CreatedAt = DateTime.Now,
                YAxle = string.Empty,
                ZAxle = string.Empty,
                XAxle = string.Empty,
            };

            try
            {
                deviMes.XAxle = devicemeasure.D.Where(x => !String.IsNullOrEmpty(x.x)).FirstOrDefault().x; //Eixo x
                    }
            catch { }
            try
            {
                deviMes.YAxle = devicemeasure.D.Where(y => !String.IsNullOrEmpty(y.y)).FirstOrDefault().y; //Eixo y
             }
            catch { }
            try
            {
                deviMes.ZAxle = devicemeasure.D.Where(z => !String.IsNullOrEmpty(z.z)).FirstOrDefault().z; //Eixo z
               }
            catch { } 

            _DeviceMeasureService.Insert(deviMes);

            respJson = "{\"T\":\"13b579\",\"R\":\"S6302$\",\"S\":\"14400\"}";
            ContentResult contRes = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
            contRes.ContentType = "application/json";
            return contRes;
        }

        #region abc
        [AllowAnonymous]           
        [HttpGet("deviceById")]
        public Motor GetDeviceById(int Id)
        {
            return _MotorService.Get(Id);
        }

        [AllowAnonymous]
        [HttpPost("createDevice")]
        public ContentResult AddDevice(MotorModel motor)
        {
            if ( motor.CompressorTypeId == 0 ) 
                 motor.CompressorTypeId = 1;

            try
            {
                var Motor = _mapper.Map<Motor>(motor);
                Motor.Id = _MotorService.GetlastCode();
                //Motor.Bushing = 
                var idMotor = _MotorService.Insert(Motor);


                var respJson = "{\"Message\":\"Equipamento Cadastrado com sucesso\",\"Id\":\"" + idMotor + "\"}";
                ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
                contRes1.StatusCode = (int)HttpStatusCode.OK;
                return contRes1;
            }
            catch (Exception e)
            {
                var respJson = "{\"Message\":\"Erro ao adicionar Equipamento\",\"Erro\":\"" + e.Message.ToString()+":"+e.InnerException.Message.ToString() + "\"}";
                ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
                contRes1.StatusCode = (int)HttpStatusCode.InternalServerError;
                return contRes1;
            }
        }

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getDetailDevices")]
        public IEnumerable<Motor> GetDetailDevices()
        {
            return _MotorService.GetAll();
        }

        //// GET: api/<MembersController>
        //[AllowAnonymous]
        //[HttpGet("GetMachine")]
        //public List<SelectListItemDTO> GetActuationType()
        //{
        //    return _MachineService.GetQueryDropDownList();
        //}

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getMachine")]
        public List<SelectListItemDTO> GetMachine()
        {
            return _MachineService.GetQueryDropDownList();
        }

      

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getFixationType")]
        public List<SelectListItemDTO> GetFixationType()
        {
            return _FixationService.GetQueryDropDownList();
        }

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getCoupling")]
        public List<SelectListItemDTO> GetCoupling()
        {
            return _CouplingService.GetQueryDropDownList();
        }

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getCardanShaftType")]
        public List<SelectListItemDTO> GetCardanShaftType()
        {
            return _CardanShaftTypeService.GetQueryDropDownList();
        }


        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getPumpType")]
        public List<SelectListItemDTO> GetPumpType ()
        {
            return _PumpTypeService.GetQueryDropDownList();
        }


        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getCompressorType")]
        public List<SelectListItemDTO> GetCompressorType()
        {
            return _CompressorTypeService.GetQueryDropDownList();
        }

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getDevice")]
        public List<SelectListItemDTO> GetDevice()
        {
            return _DeviceService.GetQueryDropDownList();
        }

        // GET: api/<MembersController>
        [AllowAnonymous]
        [HttpGet("getMotor")]
        public List<SelectListItemDTO> GetMotor()
        {
            List<SelectListItemDTO> listMotor = new List<SelectListItemDTO>
            {
                new SelectListItemDTO(){Key =  1 , Value = "Motor" },
                new SelectListItemDTO() { Key = 2,Value = "Redutores" },
                new SelectListItemDTO() {  Key = 3, Value = "Bomba"},
                new SelectListItemDTO() {  Key = 4,Value = "Ventilador / Exaustor"},
                new SelectListItemDTO(){Key = 5,Value = "Compressor"}
            };

            return listMotor;
        }

    //[AllowAnonymous]
    //// GET: api/<MembersController>
    //[HttpGet]
    //public IEnumerable<Motor> AllMembers()
    //{
    //    ////return lstMember;
    //    return _MotorService.GetAll();
    //}

    //// GET: api/<DeviceController>
    //[AllowAnonymous]
    //[HttpGet]
    //[Produces("application/json")]
    //public ContentResult GetA()
    //{
    //    string respJson = "{\"Status\":\"Active\",\"Connection\":\"Ok\"}";
    //    ContentResult contRes1 = Content(Newtonsoft.Json.Linq.JObject.Parse(respJson).ToString(), "application/json");
    //    return contRes1;
    //}


    //// GET api/<MembersController>/5
    //[HttpGet("{id}")]
    //public Member MemberByid(int id)
    //{
    //    return lstMember.Find(x => x.Id == id);
    //}

    [AllowAnonymous]
        // POST api/<MembersController>
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody] UserCredential userCredential)
        {
            var token = _jwtAuth.Authentication(userCredential.UserName, userCredential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
        #endregion
    }
}
