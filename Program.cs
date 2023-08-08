int days = 100;
Weekday weekday = Weekday.Monday;



for (int i = 1; i <= days; i++) {
    Console.WriteLine($"Day {i}, {weekday}");

    weekday = (Weekday) (((int) weekday + 1) % 7);

}

// TASKS:

// Phase 1
// Create a Cohort class - Id, list of students, HasStarted
// Add basic properties to Student - Name, Id, Grade, HasGraduated
// Add basic properties to Instructor - Name, YearsExperience
// Generate a random name
// Ask the user via the console how many days the simulation should run

// Phase 2
// Random student generator - gives them Id and Name
// Method to add student to cohort
// Method to set cohort start day (integer)