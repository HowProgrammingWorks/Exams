// Increment all numbers in dictionary

let incNumbers = (dictionary) => {
  for (key in dictionary) {
    if ((typeof dictionary[key]).charAt(0).toUpperCase() === 'N') {
      dictionary[key] = dictionary[key] + 1;
    }
  }
  return dictionary;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
