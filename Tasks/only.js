// Copy only listed values from dict
'Use strict';

const only = (obj, ...arr) => {

  const valuesList = arr.slice(0);
  const objectCopy = Object.assign({},obj);

  const keys = Object.keys(objectCopy, 'a', 'b', 'c');

  for(const keyValue of keys){

    if (!valuesList.includes(keyValue)) delete objectCopy[keyValue];

  }

  return objectCopy;
};

require('../Tests/only.js')(only);
