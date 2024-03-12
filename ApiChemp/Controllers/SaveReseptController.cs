using ApiChemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class SaveReseptController : Controller
{
    [HttpPost("PostReseptSave")]
    public IActionResult PostReseptSave([FromBody]SaveModel info)
    {
        Medcart medcart = new Medcart();
        medcart.Diagnos = info.Diagnos;
        medcart.Anamnis = info.Anamnis;
        medcart.Numbermedcart =
            Helper.Database.Medcarts.Where(x => x.Patientid == info.Patientid).Select(x => x.Numbermedcart).ToList()[0];
        medcart.Patientid = info.Patientid;
        medcart.Simptomatica = info.Simptomatica;

        Event _event = new Event();
        _event.Medcartid = Helper.Database.Medcarts
            .Where(x => x.Patientid == info.Patientid && x.Anamnis == info.Anamnis).Select(x => x.Id).ToList()[0];
        _event.Eventid = info.EventTipeid;
        _event.Doctor = info.Doctor;
        _event.Dataevent = info.Dataevent;
        _event.Nameevent = info.Nameevent;
        _event.Resultevent = info.Resultevent;
        _event.Opisanie = info.Opisanie;

        Resept resept = new Resept();
        resept.Doza = info.Doza;
        resept.Format = info.Format;
        resept.Eventid = Helper.Database.Events
            .Where(x => x.Dataevent == info.Dataevent && x.Nameevent == info.Nameevent).Select(x => x.Id).ToList()[0];
        return Ok();
    } 
}

public class SaveModel
{
    public int? Patientid { get; set; }
    public string Diagnos { get; set; } = null!;

    public string? Anamnis { get; set; }

    public string? Simptomatica { get; set; }
    
    

    public int? EventTipeid { get; set; }

    public int? Doctor { get; set; }

    public DateTime Dataevent { get; set; }

    public string Nameevent { get; set; } = null!;

    public string Resultevent { get; set; } = null!;

    public string Opisanie { get; set; } = null!;
    
    
    public int? Eventid { get; set; }

    public string Recomendation { get; set; } = null!;

    public string Preparat { get; set; } = null!;

    public string Procedur { get; set; } = null!;

    public string? Doza { get; set; }

    public string? Format { get; set; }

    public string? Napravlen { get; set; }

    public int? Issledovanie { get; set; }

    public string? Procedure { get; set; }
}