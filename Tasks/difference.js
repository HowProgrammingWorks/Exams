// Find a difference between two dictionaries
'use strict';

const dictDifference = ({...obj1}, obj2) => {
  for (const key in obj2) {
    delete obj1[key];
  }
  return obj1;
};

require('../Tests/difference.js')(dictDifference);
