// Sum all numbers from an array

const sum = (...args) => {
  let res = 0;

  const elements = args.flat(Infinity);
  for (const item of elements) {
    if (typeof item === 'number') {
      res += item;
    }
  }
  return res;
};

require('../Tests/sum.js')(sum);
