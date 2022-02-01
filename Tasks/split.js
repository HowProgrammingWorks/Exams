// Split an array into two parts

let split_Array = (index, array) => {
  begin = array.slice(0, index);
  const len = array.length;
  array = array.slice(index, len);
  return [begin, array];
};

require('../Tests/split.js')(split_Array);
