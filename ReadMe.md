# Word Counter   

#### Word Counter Program made 10/04/19

##### Hailey Gaylor

## Description

* This project will take a word and sentence provided by the user and return the amount of occurances.

## Setup/Installation Requirements

* GitHub Repository
* .NET

## Specifications

Scenerio: User will enter in a word
//[TestMethod]
        public void RepeatCounter_CountsWordsHandlesPunctuation_Int()
        
            //This method will test if our repeat counter can count words despite punctuation,
            //so we'll set the word and sentence appropriately in the Arrange portion

            //Arrange

            //Create instance of our RepeatCounter object
            //Call its constructor to pass in word and sentence
            RepeatCounter testCounter = new RepeatCounter("dog", "I, the dog, am a dog.");

            //Act

            //Create a variable for the expected count, set its value to 2
            //because we should expect for the method to find 'dog' twice in the sentence
            int expected = 2;

            //Create a variable for the actual count by calling the method
            //Our method should be written to return an int and NOT be static
            int actual = testCounter.WordCount();

            //Assert

            //Test whether the actual count that we got matches the expected count of 2
            Assert.AreEqual(expected, actual);



## Known Bugs

* No known bugs 

## Support and contact details

#### If there are any issues please contact me at haileygaylor@gmail.com
## Technologies Used

#### C#, .Net.

### License: Pending Job to pay for the License.