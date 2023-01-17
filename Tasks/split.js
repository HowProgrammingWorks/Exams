// // Split an array into two parts

const splitArray = (index, array) => {
  const begin = array.slice(0, index);
  const length = array.length;
  const end = array.slice(index, length);
  return [begin, end];
};

require('../Tests/split.js')(splitArray);
