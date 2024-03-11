using ApiChemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class RegController : Controller
{
    [HttpPost("PostReg")]
    public IActionResult PostReg([FromBody] ModelReg info)
    {
        User user = new User();
        Patient patient = new Patient();
        user.Adres = info.Adres;
        user.Emailuser = info.Emailuser;
        user.Nameuser = info.Nameuser;
        user.Phone = info.Phone;
        user.Genderuser = info.Genderuser;
        user.Roleuser = 3;
        user.Foto = info.Foto;
        Helper.Database.Users.Add(user);
        Helper.Database.SaveChanges();

        patient.Strahovcompani = info.Strahovcompani;
        patient.Pasportn = info.Pasportn;
        patient.Pasports = info.Pasports;
        patient.Userid = Helper.Database.Users.Where(x => x.Emailuser == info.Emailuser).Select(x => x.Id).ToList()[0];
        patient.Bethday = info.Bethday;
        patient.Worck = info.Worck;
        patient.Datagetmeadcart = info.Datagetmeadcart;
        patient.Datalastvisit = info.Datalastvisit;
        patient.Datanextvisit = info.Datanextvisit;
        patient.Numberpolis = info.Numberpolis;
        patient.Datafinishpolis = info.Datafinishpolis;
        Helper.Database.Patients.Add(patient);
        Helper.Database.SaveChanges();
        
        return Ok();
    }
    
    public class ModelReg
    {
        public string Nameuser { get; set; }

        public string Phone { get; set; }

        public int? Genderuser { get; set; }

        public string Adres { get; set; }

        public string? Foto { get; set; }
        public string Emailuser { get; set; }
        
        
        public int Pasportn { get; set; }

        public int Pasports { get; set; }

        public DateTime Bethday { get; set; }

        public string Worck { get; set; }

        public string Strahovcompani { get; set; }

        public DateTime Datagetmeadcart { get; set; }

        public DateTime Datalastvisit { get; set; }

        public DateTime Datanextvisit { get; set; }

        public int Numberpolis { get; set; }

        public DateTime Datafinishpolis { get; set; }
    }
}