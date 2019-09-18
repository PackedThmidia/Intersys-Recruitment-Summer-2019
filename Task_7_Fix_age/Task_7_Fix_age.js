// Write a function in JS fixage that receives an array of integers. The integers represent ages between 0 and 100.
// The function is required to join all the integers that are between 18 and 60 into a string separated with a comma and returns it.
// If there is no integer between 18 and 60, then the function returns "NA".

// For example:

// fixage([5,15,25,78,59,45]) returns 25,59,45

// and

// fixage([18,3,30,22,11,60]) returns 18,30,22,60

// and 

// fixage([1,3,3,2,11,6]) returns NA

function fixage(ages) {
  ages = ages.filter((x) => x >= 18 && x <= 60);
  if(ages.length > 0) 
    return ages.join(',');
  else 
    return "NA";
};

console.log(fixage([5,15,25,78,59,45]));
console.log(fixage([18,3,30,22,11,60]));
console.log(fixage([1,3,3,2,11,6]));
