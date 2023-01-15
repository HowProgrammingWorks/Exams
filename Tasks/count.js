use 'strict'

const count = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  keys.forEach((key) => {
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
