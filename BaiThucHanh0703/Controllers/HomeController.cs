using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult GPTB1()
    {
        return View();
    }
    [HttpPost]
    public IActionResult GPTB1(string hesoA, string hesoB)
    {
        string thongbao ="";
        double a = 0, b = 0;
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if (a==0)
        {
            thongbao = "Khong phai phuongg trinh bac nhat";
        }
        else
        {
            thongbao = gpt.GiaiPhuongTrinhB1(a, b);
        }
        ViewBag.message = thongbao;
        return View();
    }
    public IActionResult GPTB2()
    {
        return View();
    }
    [HttpPost]
        public IActionResult GPTB2(string heSoA, string heSoB, string heSoC)
    {
        string kq ="";
        double a = 0, b = 0, c = 0;
        if(!String.IsNullOrEmpty(heSoA)) a = Convert.ToDouble(heSoA); // Gia tri ma Null hoac Empty; dau = la phep an khi chay cau lenh
        if(!String.IsNullOrEmpty(heSoB)) b = Convert.ToDouble(heSoB); //chuyen doi kieu du lieu tu String sang Double
        if(!String.IsNullOrEmpty(heSoC)) c = Convert.ToDouble(heSoC);
        if(a==0) kq = "Khong phai phuong trinh bac 2";
        else
        {
            kq = gpt.GiaiPhuongTrinhB2(heSoA, heSoB, heSoC);
        }
        ViewBag.message = kq;
        return View();
    }
    


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}