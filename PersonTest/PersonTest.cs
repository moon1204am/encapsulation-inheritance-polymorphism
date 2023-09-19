using EncapsulationInheritancePolymorphism.Encapsulation;

namespace PersonTest
{
    public class PersonTest
    {
        [Fact]
        public void PersonValidAge()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();
            Person newPerson = handler.CreatePerson(29, "Jane", "Doe", 175, 50);
            var expected = 29;
            

            //Act
            var actual = handler.GetAge(newPerson);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PersonInvalidAge()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => handler.CreatePerson(0, "Jane", "Doe", 175, 50));
        }

        [Fact]
        public void PersonValidFName()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();
            Person newPerson = handler.CreatePerson(29, "Jane", "Doe", 175, 50);
            var expected = "Jane";


            //Act
            var actual = handler.GetFName(newPerson);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PersonInvalidFName()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => handler.CreatePerson(29, "A", "Doe", 175, 50));
        }

        [Fact]
        public void PersonValidLName()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();
            Person newPerson = handler.CreatePerson(29, "Jane", "Doe", 175, 50);
            var expected = "Doe";


            //Act
            var actual = handler.GetLName(newPerson);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PersonInvalidLName()
        {
            //Arrange
            PersonHandler handler = new PersonHandler();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => handler.CreatePerson(29, "Jane", "D", 175, 50));
        }
    }
}