# Unit Tests for Sample Data
In this program, the team seeds sample data to use for an automated test framework. I helped with some of unit tests, verifying that the test data created fits the requirments of the framework that uses it. Below are the two unit tests I created that I am most proud of. I used MSDN and several online resources to put together some regular expressions that help verify the sample SSN and email addresses generated by the program.


        [TestMethod]
        public void NewPersonHasValidPhoneNumberTest()
        {
            // Create an initial session state and add the command to it. 
            var initialSessionState = InitialSessionState.CreateDefault2();
            var commandEntry = new SessionStateCmdletEntry("New-RandomPerson", typeof(NewRandomPersonCommand), null);
            initialSessionState.Commands.Add(commandEntry);

            var runspace = RunspaceFactory.CreateRunspace(initialSessionState);

            runspace.Open();

            using (var powershell = PowerShell.Create(initialSessionState))
            {
                powershell.Runspace = runspace;
                powershell.AddCommand("New-RandomPerson");

                var returnedStrings = powershell.Invoke<string>();
                Assert.IsNotNull(returnedStrings);
                Assert.AreEqual(1, returnedStrings.Count);
                var jsonString = returnedStrings[0];
                Assert.IsFalse(string.IsNullOrEmpty(jsonString));

                var person = JsonConvert.DeserializeObject<PersonalInformation>(jsonString);
                Assert.IsNotNull(person);

                var thisPersonPhoneNumber = person.PhoneNumber;

                Assert.IsNotNull(thisPersonPhoneNumber);
                Assert.AreNotEqual("", thisPersonPhoneNumber);
                Assert.IsTrue(typeof(String).IsInstanceOfType(thisPersonPhoneNumber));
                Assert.IsTrue(thisPersonPhoneNumber.Length == 12);
                Assert.IsTrue(Regex.IsMatch(thisPersonPhoneNumber, @"^\d\s\d{10}$"));

            }

            runspace.Close();
        }


        [TestMethod]
        public void NewPersonHasValidEmailTest()
        {
            // Create an initial session state and add the command to it. 
            var initialSessionState = InitialSessionState.CreateDefault2();
            var commandEntry = new SessionStateCmdletEntry("New-RandomPerson", typeof(NewRandomPersonCommand), null);
            initialSessionState.Commands.Add(commandEntry);

            var runspace = RunspaceFactory.CreateRunspace(initialSessionState);

            runspace.Open();

            using (var powershell = PowerShell.Create(initialSessionState))
            {
                powershell.Runspace = runspace;
                powershell.AddCommand("New-RandomPerson");

                var returnedStrings = powershell.Invoke<string>();
                Assert.IsNotNull(returnedStrings);
                Assert.AreEqual(1, returnedStrings.Count);
                var jsonString = returnedStrings[0];
                Assert.IsFalse(string.IsNullOrEmpty(jsonString));

                var person = JsonConvert.DeserializeObject<PersonalInformation>(jsonString);
                Assert.IsNotNull(person);

                var thisPersonEmail = person.EmailAddress;

                Assert.IsNotNull(thisPersonEmail);
                Assert.AreNotEqual("", thisPersonEmail);
                Assert.IsTrue(typeof(String).IsInstanceOfType(thisPersonEmail));
                Assert.IsTrue(Regex.IsMatch(thisPersonEmail, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,63}$", 
                        RegexOptions.IgnoreCase));

            }

            runspace.Close();
        }