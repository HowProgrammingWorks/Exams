// Copy only listed values from dict
'Use strict';

const only = (obj, ...only) => {

  const objectCopy = Object.assign({},obj);

  const keys = Object.keys(obj, 'a', 'b', 'c');

  for(const Z of keys){

    if (!only.includes(Z)) delete objectCopy[Z];

  }

  return objectCopy;
};

require('../Tests/only.js')(only);
