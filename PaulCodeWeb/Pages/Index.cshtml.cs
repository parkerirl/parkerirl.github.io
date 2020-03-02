using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PaulCodeWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //ViewData[""]; 
       /*
            {
                Console.WriteLine("[PAULCODE Alpha Ver. 0.0.1]");
                int Range_1, Range_2;

                Console.WriteLine("\nPlease enter a size for scale 1: ");
                Range_1 = Convert.ToInt32(Console.ReadLine());
                int[] Scale_1 = new int[Range_1];
                Console.WriteLine("\n");
                for (int i = 0; i < Range_1; i++)
                {
                    Console.WriteLine($"Please enter scale degree {i + 1}");
                    Scale_1[i] = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("\nPlease enter a size for scale 2: ");
                Range_2 = Convert.ToInt32(Console.ReadLine());
                int[] Scale_2 = new int[Range_2];
                Console.WriteLine("\n");
                for (int i = 0; i < Range_2; i++)
                {
                    Console.WriteLine($"Please enter scale degree {i + 1}");
                    Scale_2[i] = Convert.ToInt32(Console.ReadLine());
                }

                int Slot_1 = 0, Slot_2 = 0;
                for (int j = 0; j < 256; j++)
                {

                    if (Scale_1[Slot_1] == Scale_2[Slot_2])
                    {
                        Console.WriteLine("----------------------------------\nMATCH AT:");
                        Console.WriteLine($"Scale 1 degree: {Slot_1} | pitch: {Scale_1[Slot_1]}");
                        Console.WriteLine($"Scale 2 degree: {Slot_2} | pitch: {Scale_2[Slot_2]}");
                    }
                    else
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"Scale 1 degree: {Slot_1} | pitch: {Scale_1[Slot_1]}");
                        Console.WriteLine($"Scale 2 degree: {Slot_2} | pitch: {Scale_2[Slot_2]}");
                    }

                    Slot_1++;
                    Slot_2++;
                    if (Slot_1 >= Range_1) Slot_1 = 0;
                    if (Slot_2 >= Range_2) Slot_2 = 0; 
                }
            }*/
        }
    }
}