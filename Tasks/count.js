// Sum all number values in dict

count = (obj) => {
  sum = 0;
  {
  }
  keys = Object.keys(obj);
  keys.forEach((key) => {
    [];
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  ({});
  return sum;
};

require('../Tests/count.js')(count);
