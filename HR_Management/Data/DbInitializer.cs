using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management.Models.HRModels;

namespace HR_Management.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();//if db is not exist ,it will create database .but ,do nothing .

            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            //Employee Seed Data
            var employees = new Employee[]
            {
                new Employee{empId="0",password="password0",fname="Alex",lname="Matthew",address="123 Infinity Drive Lawerence, CA 98766", email="amatthew@gmail.com", status= "Teminated", department="Sales", jobTitle="Employee", vacationDays=13, sickTime=4},
                new Employee{empId="1",password="password1",fname="Anastasia",lname="Akel",address="123 Baker Street New York, NY 11422", email="aakel@gmail.com", status= "Full-Time", department="Sales", jobTitle="Manager", vacationDays=20, sickTime=1},
                new Employee{empId="2",password="password2",fname="Joe",lname="Serra",address="1720 Woodland Ave Atlanta, GA 30019", email="jserra@gmail.com", status= "Full-Time", department="Engineering", jobTitle="Employee", vacationDays=13, sickTime=7},
                new Employee{empId="3",password="password3",fname="Sabrina",lname="Dia",address="907 Secret Cove Lane Minneapolis, MI 58390", email="sdia@gmail.com", status= "Intern", department="Design", jobTitle="Employee", vacationDays=0, sickTime=0},
                new Employee{empId="4",password="password4",fname="Liz",lname="Woods",address="234 Grand Dr Annex, FL 98793", email="lwoods@gmail.com", status= "Full-Time", department="Human Resources", jobTitle="Manager", vacationDays=40, sickTime=5},
                new Employee{empId="5",password="password5",fname="Rebecca",lname="Todd",address="45 Rodeo Dr Hollywood, CA 49328", email="rtodd@gmail.com", status= "Full-Time", department="Quality Assurance", jobTitle="Manager", vacationDays=13, sickTime=7},
                new Employee{empId="6",password="password6",fname="Desiree",lname="Strong",address="456 Kinsey Road Austin, Texas 87897", email="dstrong@gmail.com", status= "Full-Time", department="Human Resources", jobTitle="HR", vacationDays=20, sickTime=10},
                new Employee{empId="7",password="password7",fname="Ekira",lname="Johnson",address="345 Waterfront Circle Portland, OR", email="ejohnson@gmail.com", status= "Intern", department="Human Resources", jobTitle="HR", vacationDays=6, sickTime=4},
                new Employee{empId="8",password="password8",fname="Andrew",lname="Matthew",address="234 Yellowbrick Road Las Vegas, NV 83487", email="amatthew@gmail.com", status= "Full-Time", department="Design", jobTitle="Employee", vacationDays=8, sickTime=3},
                new Employee{empId="9",password="password9",fname="Richard",lname="Wei",address="473 Winterfold Lane Orlando, FL 73749", email="rwei@gmail.com", status= "Full-Time", department="Engineering", jobTitle="Manager", vacationDays=30, sickTime=20},
                new Employee{empId="10",password="password10",fname="Fanny",lname="Lopez",address="907 Queensridge Circle Tutledge, AL 83747", email="flopez@gmail.com", status= "Full-Time", department="Engineering", jobTitle="Employee", vacationDays=10, sickTime=4},
                new Employee{empId="11",password="password11",fname="Kelsey",lname="Gonzales",address="837 Petrawood Island Waikiki, HI", email="kgonzales@gmail.com", status= "Full-Time", department="Design", jobTitle="Manager", vacationDays=1, sickTime=9},
                new Employee{empId="12",password="password12",fname="Emeka",lname="Ugwo",address="5832 Mustard Grove Baltimore, MD 54953", email="eugwo@gmail.com", status= "Part-Time", department="Sales", jobTitle="Employee", vacationDays=20, sickTime=4},
                new Employee{empId="13",password="password13",fname="Stephanie",lname="Jean",address="9485 Flower Dr Blessings, MO 65432", email="sjean@gmail.com", status= "Terminated", department="Quality Assurance", jobTitle="Employee", vacationDays=20, sickTime=7},

            };
            foreach (Employee e in employees)
            {
                context.Employee.Add(e);
            }
            context.SaveChanges();



            // Position Info Seed Data
            if (context.PositionInfo.Any())
            {
                return;   // DB has been seeded
            }

            var positionInfos = new PositionInfo[]
            {
                new PositionInfo{empId="0", jobTitle="Sales Representative II", jobDescription="Sell retail products, goods and services to customers. Sales representatives work with customers to find what they want, create solutions and ensure a smooth sales process.", salary=40000}, 
                new PositionInfo{empId="1", jobTitle="Sales Manager", jobDescription="Manage all the sales representatives", salary=100000},
                new PositionInfo{empId="2", jobTitle="Engineer I", jobDescription="Work in a variety of fields to analyze, develop and evaluate large-scale, complex systems. This can mean and improve and maintaining current systems or creating brand new projects. Engineers will design and draft blueprints, visit systems in the field and manage projects.", salary=80000}, 
                new PositionInfo{empId="3", jobTitle="Design Intern", jobDescription="Learn fron the full time design employees and produce a project by the end of the internship.", salary=20000}, 
                new PositionInfo{empId="4", jobTitle="Human Resource Manager", jobDescription="Lead an organization's HR programs and policies as they apply to employee relations, compensation, benefits, safety, performance and staffing levels.", salary=90000}, 
                new PositionInfo{empId="5", jobTitle="Quality Assurance Manager", jobDescription="Determine, negotiate and agree on in-house quality procedures, standards and specifications. assessing customer requirements and ensuring that these are met.", salary=95000}, 
                new PositionInfo{empId="6", jobTitle="Human Resources Representative", jobDescription="Recruit, screen, interview and place workers. Handle employee relations, payroll and benefits and training.", salary=44000},
                new PositionInfo{empId="7", jobTitle="Human Resources Intern", jobDescription="Learn fron the full time human resources employees and present a process they improved by the end of the internship.", salary=10000},
                new PositionInfo{empId="8", jobTitle="Design II", jobDescription="Create visual concepts, by hand or using computer software, to communicate ideas that inspire, inform, or captivate consumers. They develop the overall layout and production design for advertisements, brochures, magazines, and corporate reports.", salary=60000}, 
                new PositionInfo{empId="9", jobTitle="Engineering Manager", jobDescription="Confer with management, production, and marketing staff to discuss project specifications and procedures. Coordinate and direct projects, making detailed plans to accomplish goals and directing the integration of technical activities.", salary=150000}, 
                new PositionInfo{empId="10", jobTitle="Engineering II", jobDescription="Work in a variety of fields to analyze, develop and evaluate large-scale, complex systems. This can mean and improve and maintaining current systems or creating brand new projects. Engineers will design and draft blueprints, visit systems in the field and manage projects.", salary=100000}, 
                new PositionInfo{empId="11", jobTitle="Design Manager", jobDescription="Manage design or graphics teams and departments. Be extremely innovative, artistic and creative. Collaborate on projects with their colleagues, delegate tasks and check for quality and consistency.", salary=80000},
                new PositionInfo{empId="12", jobTitle="Sales Representative I", jobDescription="Sell retail products, goods and services to customers. Sales representatives work with customers to find what they want, create solutions and ensure a smooth sales process.", salary=35000}, 
                new PositionInfo{empId="13", jobTitle="Quality Assurance I", jobDescription="Develop test plans, test cases and test scripts for projects, among other assigned duties.", salary=70000}, 

            };
            foreach (PositionInfo p in positionInfos)
            {
                context.PositionInfo.Add(p);
            }
            context.SaveChanges();


            // Time Off Seed Data 
            if (context.TimeOff.Any())
            {
                return;   // DB has been seeded
            }

            var timeOffs = new TimeOff[]
            {
                new TimeOff{empId="0", startDate="2017-12-15", endDate="2017-12-23", approve=true, type="Vacation"}, 
                new TimeOff{empId="1", startDate="2017-11-01", endDate="2017-11-15", approve=false, type="Sick Day"}, 
                new TimeOff{empId="1", startDate="2017-11-20", endDate="2017-11-31", approve=false, type="Vacation"},
                new TimeOff{empId="3", startDate="2018-08-01", endDate="2018-09-01", approve=false, type="Vacation"},
                new TimeOff{empId="4", startDate="2018-01-01", endDate="2018-09-01", approve=true, type="Vacation"}, 
                new TimeOff{empId="4", startDate="2018-09-01", endDate="2018-09-04", approve=false, type="Vacation"}, 
                new TimeOff{empId="6", startDate="2018-03-01", endDate="2018-03-07", approve=false, type="Vacation"},
                new TimeOff{empId="7", startDate="2018-02-01", endDate="2018-02-14", approve=false, type="Sick Day"},
                new TimeOff{empId="9", startDate="2018-06-17", endDate="2018-06-20", approve=false, type="Vacation"}, 
                new TimeOff{empId="9", startDate="2018-04-13", endDate="2018-09-01", approve=false, type="Vacation"}, 
                new TimeOff{empId="10", startDate="2018-06-01", endDate="2018-09-01", approve=false, type="Sick Day"}, 
                new TimeOff{empId="11", startDate="2017-12-09", endDate="2017-12-12", approve=true, type="Sick Day"},
                new TimeOff{empId="13", startDate="2018-11-01", endDate="2018-11-17", approve=false, type="Sick Day"},
                new TimeOff{empId="13", startDate="2018-12-01", endDate="2019-01-01", approve=false, type="Vacation"}, 

            };
            foreach (TimeOff t in timeOffs)
            {
                context.TimeOff.Add(t);
            }
            context.SaveChanges();




            // Reviews Seed Data
            if (context.Reviews.Any())
            {
                return;   // DB has been seeded
            }

            var reviews = new Reviews[]
            {
                new Reviews{empId="0", date="2017-12-03", title="2017 Review", manager="1", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="0", date="2017-02-15", title="2017 Review", manager="1", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="12", date="2014-01-20", title="2014 Review", manager="1", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{empId="6", date="2010-06-09", title="2010 Review", manager="4", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{empId="6", date="2003-03-21", title="2003 Review", manager="4", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="7", date="2003-09-18", title="2003 Review", manager="4", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="13", date="2005-04-27", title="2005 Review", manager="5", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="13", date="2016-10-20", title="2016 Review", manager="5", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="2", date="2014-05-30", title="2014 Review", manager="9", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="10", date="2013-07-10", title="2013 Review", manager="9", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="10", date="2003-11-23", title="2003 Review", manager="9", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{empId="3", date="2004-02-19", title="2004 Review", manager="11", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="8", date="2000-04-12", title="2000 Review", manager="11", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{empId="8", date="2012-04-08", title="2012 Review", manager="11", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 

            };
            foreach (Reviews r in reviews)
            {
                context.Reviews.Add(r);
            }
            context.SaveChanges();

        }
    }
}
