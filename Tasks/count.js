use 'strict'

const counOfNumbers = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  for (const value of values) {
   if (typeof value === 'number') sum += value;
  };
  return sum;
};

require('../Tests/count.js')(countOfNumbers);
