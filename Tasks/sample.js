// Get one random element from array

const SAMPLE = arr => {
  arr = arr[
    Math.floor(Math.random()* arr.length)
  ]; return arr
};

const result = SAMPLE([123, 456, 789, 222, 333, 444]);
console.log(result);
