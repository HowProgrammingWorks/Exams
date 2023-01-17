// // Split an array into two parts

const splitArray = (index, array) => {
  const begin = array.slice(0, index);
  const len = array.length;
  const end = array.slice(index, len);
  return [begin, end];
};

require('../Tests/split.js')(splitArray);
