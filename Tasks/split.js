// // Split an array into two parts

const splitArray = (index, array) => {
  begin = array.slice(0, index);
  const len = array.length;
  array = array.slice(index, len);
  return [begin, array];
};

require('../Tests/split.js')(splitArray);
