namespace MusicSchoolApp
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                var inputLine = File.ReadLines("input.txt");
                List<SchoolMember> members = new List<SchoolMember>();  
                foreach (var line in inputLine) 
                {
                    var data=line.Split(';').ToList();
                    if (data[0]== "Student")
                    {
                        string name = data[1];
                        int age=int.Parse(data[2]);
                        string instrument=data[3];
                        int practiceHours=int.Parse(data[4]);
                        SchoolMember mebber=new Student(name,age,instrument, practiceHours);
                    }
                }
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
