using System;
using System.Collections.Generic;
using System.IO;
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

			byte[] imageData = null;
			FileInfo fileInfo = new FileInfo("~/images/profile.png");
			long imageFileLength = fileInfo.Length;
			FileStream fs = new FileStream("~/images/profile.png", FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			imageData = br.ReadBytes((int)imageFileLength);

            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            //Employee Seed Data
            var employees = new Employee[]
            {
                new Employee{empId=0,password="password0",fname="Alex",lname="Matthew",address="123 Infinity Drive Lawerence, CA 98766", email="amatthew@gmail.com", phoneNumber="1234567890", status= "Full-Time", department="Sales", jobTitle=0, vacationDays=13, sickTime=4, startDate="05/12/2010", endDate="", managerID=2, employeeType=0, rank=1, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=1,password="password1",fname="Anastasia",lname="Akel",address="123 Baker Street New York, NY 11422", email="aakel@gmail.com", phoneNumber="2345678901", status= "Full-Time", department="Sales", jobTitle=1, vacationDays=20, sickTime=1, startDate="03/30/2016", endDate="", managerID=14, employeeType=1, rank=3, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=2,password="password2",fname="Joe",lname="Serra",address="1720 Woodland Ave Atlanta, GA 30019", email="jserra@gmail.com", phoneNumber="3456789012", status= "Terminated", department="Engineering", jobTitle=2, vacationDays=13, sickTime=7, startDate = "02/14/2014", endDate="05/12/2016", managerID=9, employeeType=0, rank=0, ImageData = imageData, isTerminated = true, terminationReason = "Lorem ipsum dolor sit amet"},
                new Employee{empId=3,password="password3",fname="Sabrina",lname="Dia",address="907 Secret Cove Lane Minneapolis, MI 58390", email="sdia@gmail.com", phoneNumber="4567890123", status= "Intern", department="Design", jobTitle=3, vacationDays=0, sickTime=0, startDate="12/25/2015", endDate="", managerID=11, employeeType=0, rank=4, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=4,password="password4",fname="Liz",lname="Woods",address="234 Grand Dr Annex, FL 98793", email="lwoods@gmail.com", phoneNumber="5678901234", status= "Full-Time", department="Human Resources", jobTitle=4, vacationDays=40, sickTime=5, startDate="10/31/2000", endDate="", managerID=14, employeeType=4, rank=5, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=5,password="password5",fname="Rebecca",lname="Todd",address="45 Rodeo Dr Hollywood, CA 49328", email="rtodd@gmail.com", phoneNumber="6789012345", status= "Full-Time", department="Quality Assurance", jobTitle=5, vacationDays=13, sickTime=7, startDate="03/04/2005", endDate="", managerID=14, employeeType=1, rank=6, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=6,password="password6",fname="Desiree",lname="Strong",address="456 Kinsey Road Austin, Texas 87897", email="dstrong@gmail.com", phoneNumber="7890123456", status= "Full-Time", department="Human Resources", jobTitle=6, vacationDays=20, sickTime=10, startDate="02/03/2004", endDate="", managerID=4, employeeType=2, rank=2, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=7,password="password7",fname="Ekira",lname="Johnson",address="345 Waterfront Circle Portland, OR", email="ejohnson@gmail.com", phoneNumber="8901234567", status= "Intern", department="Human Resources", jobTitle=7, vacationDays=6, sickTime=4, startDate="01/01/2016", endDate="", managerID=4, employeeType=2, rank=8, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=8,password="password8",fname="Andrew",lname="Matthew",address="234 Yellowbrick Road Las Vegas, NV 83487", email="amatthew@gmail.com", phoneNumber="9012345678", status= "Full-Time", department="Design", jobTitle=8, vacationDays=8, sickTime=3, startDate="07/30/2015", endDate="", managerID=11, employeeType=0, rank=6, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=9,password="password9",fname="Richard",lname="Wei",address="473 Winterfold Lane Orlando, FL 73749", email="rwei@gmail.com", phoneNumber="0123456789", status= "Full-Time", department="Engineering", jobTitle=9, vacationDays=30, sickTime=20, startDate="05/15/2007", endDate="", managerID=14, employeeType=1, rank=9, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=10,password="password10",fname="Fanny",lname="Lopez",address="907 Queensridge Circle Tutledge, AL 83747", email="flopez@gmail.com", phoneNumber="1122334455", status= "Full-Time", department="Engineering", jobTitle=10, vacationDays=10, sickTime=4, startDate="09/09/2009", endDate="", managerID=9, employeeType=0, rank=7, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=11,password="password11",fname="Kelsey",lname="Gonzales",address="837 Petrawood Island Waikiki, HI", email="kgonzales@gmail.com", phoneNumber="2233445566", status= "Full-Time", department="Design", jobTitle=11, vacationDays=1, sickTime=9, startDate="04/13/2000", endDate="", managerID=14, employeeType=1, rank=10, ImageData=imageData, isTerminated=false, terminationReason=""},
                new Employee{empId=12,password="password12",fname="Emeka",lname="Ugwo",address="5832 Mustard Grove Baltimore, MD 54953", email="eugwo@gmail.com", phoneNumber="3344556677", status= "Part-Time", department="Sales", jobTitle=12, vacationDays=20, sickTime=4, startDate="11/27/2013", endDate="05/12/2016", managerID=0, employeeType=0, rank=0, ImageData=imageData, isTerminated=true, terminationReason="Lorem ipsum dolor sit amet"},
                new Employee{empId=13,password="password13",fname="Stephanie",lname="Jean",address="9485 Flower Dr Blessings, MO 65432", email="sjean@gmail.com", phoneNumber="4455667788", status= "Terminated", department="Quality Assurance", jobTitle=13, vacationDays=20, sickTime=7, startDate="06/17/2016", endDate="08/12/2016", managerID=0, employeeType=0, rank=0, ImageData=imageData, isTerminated=true, terminationReason="Lorem ipsum dolor sit amet"},
				new Employee{empId=14,password="password14",fname="The",lname="Boss",address="100 MakeTheRules Lane Bossy, MA, 10000", email="boss@gmail.com", phoneNumber="9999999999", status= "Full-Time", department="Executive", jobTitle=14, vacationDays=100, sickTime=700, startDate="01/17/2000", endDate="", managerID=14, employeeType=5, rank=0, ImageData=imageData, isTerminated=false, terminationReason=""},

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
                new PositionInfo{ID=0, status=true, managerID=1, empId=0, jobTitle="Sales Representative II", jobDescription="Sell retail products, goods and services to customers. Sales representatives work with customers to find what they want, create solutions and ensure a smooth sales process.", salary=40000}, 
                new PositionInfo{ID=1, status=true, managerID=14, empId=1, jobTitle="Sales Manager", jobDescription="Manage all the sales representatives", salary=100000},
                new PositionInfo{ID=2, status=true, managerID=9, empId=2, jobTitle="Engineer I", jobDescription="Work in a variety of fields to analyze, develop and evaluate large-scale, complex systems. This can mean and improve and maintaining current systems or creating brand new projects. Engineers will design and draft blueprints, visit systems in the field and manage projects.", salary=80000}, 
                new PositionInfo{ID=3, status=true, managerID=11, empId=3, jobTitle="Design Intern", jobDescription="Learn fron the full time design employees and produce a project by the end of the internship.", salary=20000}, 
                new PositionInfo{ID=4, status=true, managerID=14, empId=4, jobTitle="Human Resource Manager", jobDescription="Lead an organization's HR programs and policies as they apply to employee relations, compensation, benefits, safety, performance and staffing levels.", salary=90000}, 
                new PositionInfo{ID=5, status=true, managerID=14, empId=5, jobTitle="Quality Assurance Manager", jobDescription="Determine, negotiate and agree on in-house quality procedures, standards and specifications. assessing customer requirements and ensuring that these are met.", salary=95000}, 
                new PositionInfo{ID=6, status=true, managerID=4, empId=6, jobTitle="Human Resources Representative", jobDescription="Recruit, screen, interview and place workers. Handle employee relations, payroll and benefits and training.", salary=44000},
                new PositionInfo{ID=7, status=true, managerID=4, empId=7, jobTitle="Human Resources Intern", jobDescription="Learn fron the full time human resources employees and present a process they improved by the end of the internship.", salary=10000},
                new PositionInfo{ID=8, status=true, managerID=11, empId=8, jobTitle="Design II", jobDescription="Create visual concepts, by hand or using computer software, to communicate ideas that inspire, inform, or captivate consumers. They develop the overall layout and production design for advertisements, brochures, magazines, and corporate reports.", salary=60000}, 
                new PositionInfo{ID=9, status=true, managerID=14, empId=9, jobTitle="Engineering Manager", jobDescription="Confer with management, production, and marketing staff to discuss project specifications and procedures. Coordinate and direct projects, making detailed plans to accomplish goals and directing the integration of technical activities.", salary=150000}, 
                new PositionInfo{ID=10, status=true, managerID=9, empId=10, jobTitle="Engineering II", jobDescription="Work in a variety of fields to analyze, develop and evaluate large-scale, complex systems. This can mean and improve and maintaining current systems or creating brand new projects. Engineers will design and draft blueprints, visit systems in the field and manage projects.", salary=100000}, 
                new PositionInfo{ID=11, status=true, managerID=14, empId=11, jobTitle="Design Manager", jobDescription="Manage design or graphics teams and departments. Be extremely innovative, artistic and creative. Collaborate on projects with their colleagues, delegate tasks and check for quality and consistency.", salary=80000},
                new PositionInfo{ID=12, status=true, managerID=1, empId=12, jobTitle="Sales Representative I", jobDescription="Sell retail products, goods and services to customers. Sales representatives work with customers to find what they want, create solutions and ensure a smooth sales process.", salary=35000}, 
                new PositionInfo{ID=13, status=true, managerID=5, empId=13, jobTitle="Quality Assurance I", jobDescription="Develop test plans, test cases and test scripts for projects, among other assigned duties.", salary=70000},
				new PositionInfo{ID=14, status=true, managerID=99, empId=14, jobTitle="CEO", jobDescription="The Boss.", salary=500000},

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
                new TimeOff{ID=0, empId=0, startDate="2017-12-15", endDate="2017-12-23", description="", approve=true, type="Vacation"}, 
                new TimeOff{ID=1, empId=1, startDate="2017-11-01", endDate="2017-11-15", description="", approve=false, type="Sick Day"}, 
                new TimeOff{ID=2, empId=3, startDate="2018-08-01", endDate="2018-09-01", description="", approve=false, type="Vacation"},
                new TimeOff{ID=3, empId=4, startDate="2018-01-01", endDate="2018-09-01", description="", approve=true, type="Vacation"}, 
                new TimeOff{ID=4, empId=5, startDate="2018-09-01", endDate="2018-09-04", description="", approve=false, type="Vacation"}, 
                new TimeOff{ID=5, empId=6, startDate="2018-03-01", endDate="2018-03-07", description="", approve=false, type="Vacation"},
                new TimeOff{ID=6, empId=7, startDate="2018-02-01", endDate="2018-02-14", description="", approve=false, type="Sick Day"},
                new TimeOff{ID=7, empId=9, startDate="2018-06-17", endDate="2018-06-20", description="", approve=false, type="Vacation"}, 
                new TimeOff{ID=8, empId=9, startDate="2018-04-13", endDate="2018-09-01", description="", approve=false, type="Vacation"}, 
                new TimeOff{ID=9, empId=10, startDate="2018-06-01", endDate="2018-09-01", description="", approve=false, type="Sick Day"}, 
                new TimeOff{ID=10, empId=11, startDate="2017-12-09", endDate="2017-12-12", description="", approve=true, type="Sick Day"},
                new TimeOff{ID=11, empId=8, startDate="2018-11-01", endDate="2018-11-17", description="", approve=false, type="Sick Day"},
                new TimeOff{ID=12, empId=13, startDate="2018-12-01", endDate="2019-01-01", description="", approve=false, type="Vacation"}, 

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
                new Reviews{ID=0, empId=0, date="2017-12-03", title="2017 Review", manager=1, score=99.5, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=1, empId=0, date="2017-02-15", title="2017 Review", manager=1, score=25.7, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=2, empId=12, date="2014-01-20", title="2014 Review", manager=1, score=40.6, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{ID=3, empId=6, date="2010-06-09", title="2010 Review", manager=4, score=60, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{ID=4, empId=6, date="2003-03-21", title="2003 Review", manager=4, score=90, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=5, empId=7, date="2003-09-18", title="2003 Review", manager=4, score=45, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=6, empId=13, date="2005-04-27", title="2005 Review", manager=5, score=34, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=7, empId=13, date="2016-10-20", title="2016 Review", manager=5, score=67, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=8, empId=2, date="2014-05-30", title="2014 Review", manager=9, score=78, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=9, empId=10, date="2013-07-10", title="2013 Review", manager=9, score=80, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=10, empId=10, date="2003-11-23", title="2003 Review", manager=9, score=50, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Reviews{ID=11, empId=3, date="2004-02-19", title="2004 Review", manager=11, score=43, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=12, empId=8, date="2000-04-12", title="2000 Review", manager=11, score=67, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 
                new Reviews{ID=13, empId=8, date="2012-04-08", title="2012 Review", manager=11, score=80, description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}, 

            };
            foreach (Reviews r in reviews)
            {
                context.Reviews.Add(r);
            }
            context.SaveChanges();




			// Complaints Seed Data 
			if (context.Complaints.Any())
			{
				return;   // DB has been seeded
			}

			var complaints = new Complaints[]
			{
				new Complaints{ID=0, status="Verifying", empId=0, date="2017-12-03", title="2017 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=1, status="Submitted", empId=0, date="2017-02-15", title="2017 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=2, status="Investigation In Progress", empId=12, date="2014-01-20", title="2014 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=3, status="Resolved", empId=6, date="2010-06-09", title="2010 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=4, status="Resolved", empId=6, date="2003-03-21", title="2003 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=5, status="Received", empId=7, date="2003-09-18", title="2003 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=6, status="Pending", empId=13, date="2005-04-27", title="2005 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=7, status="Received", empId=13, date="2016-10-20", title="2016 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=8, status="Resolved", empId=2, date="2014-05-30", title="2014 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=9, status="Resolved", empId=10, date="2013-07-10", title="2013 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=10, status="Resolved", empId=10, date="2003-11-23", title="2003 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=11, status="Resolved", empId=3, date="2004-02-19", title="2004 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=12, status="Resolved", empId=8, date="2000-04-12", title="2000 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
				new Complaints{ID=13, status="Resolved", empId=8, date="2012-04-08", title="2012 Review", description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},

			};
            foreach (Complaints c in complaints)
			{
				context.Complaints.Add(c);
			}
			context.SaveChanges();


			// Messages Seed Data 
			if (context.Messages.Any())
			{
				return;   // DB has been seeded
			}

			var messages = new Messages[]
			{
                new Messages{ID=0, title="Lorem", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=0, date="10/31/2016", isRead=true},
				new Messages{ID=1, title="Ipsum", content="labore et dolore magna aliqua.", employeeFromID=14, employeeToID=4, date="04/28/2014", isRead=false},
				new Messages{ID=2, title="Dolor", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=10, date="01/5/2012", isRead=true},
				new Messages{ID=3, title="Sit", content="labore et dolore magna aliqua.", employeeFromID=14, employeeToID=9, date="02/28/2014", isRead=false},
				new Messages{ID=4, title="Amet", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=6, date="06/30/2017", isRead=true},
				new Messages{ID=5, title="Consectetur", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=9, date="11/20/2009", isRead=false},
				new Messages{ID=6, title="Adipiscing", content="labore et dolore magna aliqua.", employeeFromID=7, employeeToID=8, date="05/15/2013", isRead=false},
				new Messages{ID=7, title="Elit", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=5, date="04/03/2012", isRead=true},
				new Messages{ID=8, title="Sed", content="labore et dolore magna aliqua.", employeeFromID=7, employeeToID=10, date="09/09/2010", isRead=false},
				new Messages{ID=9, title="Do", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=0, date="08/15/2011", isRead=false},
				new Messages{ID=10, title="Eiusmod", content="labore et dolore magna aliqua.", employeeFromID=11, employeeToID=10, date="10/31/2013", isRead=true},
				new Messages{ID=11, title="Tempor", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=11, date="07/06/2012", isRead=true},
				new Messages{ID=12, title="Incididunt", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=10, date="10/04/2008", isRead=false},
				new Messages{ID=13, title="Ut", content="labore et dolore magna aliqua.", employeeFromID=4, employeeToID=9, date="10/31/2016", isRead=false},

			};
            foreach (Messages m in messages)
			{
				context.Messages.Add(m);
			}
			context.SaveChanges();

        }
    }
}
