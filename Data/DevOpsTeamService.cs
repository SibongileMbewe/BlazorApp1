namespace BlazorApp1.Data
{
    public class DevOpsTeamService
    {
        private static readonly string[] EmployeeCodes = new[]
        {
            "0001", "0002", "0003", "0004", "0005"
        };
        private static readonly string[] FirstNames = new[]
        {
            "Mahesh", "Mike", "Raj", "Praveen", "Dinesh"
        };

        private static readonly string[] LastNames = new[]
        {
            "Chand", "Gold", "Beniwal", "Kumar", "Beniwal"
        };

        private static readonly string[] Designations = new[]
        {
            "Data Analyst", "DevOps Engineer", "Product Manager", "Build Engineer", "Release Manager"
        };

        public Task<DevOpsTeam[]> DevAsync()
        {
            var team = new DevOpsTeam();

            return Task.FromResult(Enumerable.Range(0, 5).Select(Id => new DevOpsTeam
            {
                //Id = team.Id 
                EmployeeCode= EmployeeCodes[Id],
                FirstName= FirstNames[Id],  
                LastName= LastNames[Id],    
                Designation= Designations[Id],

                //EmployeeCode = EmployeeCodes[Random.Shared.Next(EmployeeCodes.Length)],
                //FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
                //LastName = LastNames[Random.Shared.Next(LastNames.Length)],
                //Designation = Designations[Random.Shared.Next(Designations.Length)]

            }).ToArray());
        }
    }
}
