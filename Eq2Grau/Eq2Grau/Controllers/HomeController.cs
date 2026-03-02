using Eq2Grau.Models;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace Eq2Grau.Controllers {
   public class HomeController:Controller {

      /// <summary>
      /// 'porta' de entrada no programa
      /// </summary>
      /// <returns></returns>
      public IActionResult Index(string A, string B, string C) {
         /*
          * Algoritmo:
          * ler parâmetros A, B, C
          * se A, B, e C forem números e A=/=0
          *    calcular raízes
          *    mostrar resultado x1 e x2
          * senão, 
          *    mostrar mensagem de erro
          */


         // validar se A, B, e C forem números e A=/=0
         // if(!float.TryParse(A, out float a)) { }

         float.TryParse(A, out float a);
         float.TryParse(B, out float b);
         float.TryParse(C, out float c);

         // Calcular Raízes
         float delta = b*b-4*a*c;

         float x1 = (-b + MathF.Sqrt(delta))/(2*a);
         float x2 = (-b - MathF.Sqrt(delta))/(2*a);

         // enviar os dados calculados para a View
         ViewBag.X1 = x1;
         ViewBag.X2 = x2;


         return View();
      }

      public IActionResult Privacy() {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error() {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
