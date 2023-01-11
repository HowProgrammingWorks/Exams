// Generate random integer value in given range

const random = (min, max) => {
  if (max === undefined)  max = min;
  return Math.floor(Math.random() * (max - min) + min)
};

require('../Tests/random.js')(Random);
