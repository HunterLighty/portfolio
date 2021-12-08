function myfunc() {

  //For loop to count 1-100
  for (var counter = 1; counter <= 100; counter++)

  //Variable to establish all numbers as prime until proven otherwise 
  {
    var prime = true;

    //Creates a for loop with a variable to use in testing every possible divisor of counter.
    for (var i = 2; i <= (counter - 1); i++)

    //If the current number divided by the increment has a remainder of 0, it is officially not prime anymore.   
    {
      if (counter % i === 0) {
        prime = false;
      }
    }

    //If after going through all the numbers between 2 and one less than the number and none of them were evenly divided (no remainder) not_prime will still be false and the console will print the number.
    if (prime === true) {
      console.log(counter);
    }
  }
}

myfunc();
