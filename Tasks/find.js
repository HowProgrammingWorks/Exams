// Find key by value
'use strict';

const getKey = (object, ...rest) => {
  const value = rest.pop();
  const keys = Object.keys(object);
  for (const key of keys) {
    if (object[key] === value) return key;
  }
  return undefined;
};

require('../Tests/find.js')(getKey);
