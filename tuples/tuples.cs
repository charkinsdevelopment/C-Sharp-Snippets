namespace Tuples
{
  //Many developers build a POCO class in order to return multiple values from a method. 
  //Tuples are initiated in .NET Framework 4.0. They can be used effectively as follows
  
  public class TupleExample
  {
    public Tuple < int, string, string > GetEmployee()

    int employeeId = 1001;

    string firstName = "Rudy";

    string lastName = "Koertson";

    //Create a tuple and return

    return Tuple.Create(employeeId, firstName, lastName);
  }
}
