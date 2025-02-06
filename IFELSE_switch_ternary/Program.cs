


/*
 *  if (true\false) {
 *      code to execute if TRUE
 *  } else {
 *      code to execute if FALSE
 *  }
 */
 
 string temperature = Console.ReadLine();
 int numTemp;

 if (int.TryParse(temperature, out int temperatureInt))
 {
     numTemp = temperatureInt;
 }
 else
 {
     Console.WriteLine("Please enter a valid temperature");
 }