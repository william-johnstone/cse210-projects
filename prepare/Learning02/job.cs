using System;

    //Object = job 
    //Responsibilities: company, job title, start year, end year
    //Behaviors: "Job Title (Company) StartYear-EndYear"
    
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }