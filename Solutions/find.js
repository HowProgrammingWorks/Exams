// Find key by value
'use strict'

const find = (object, ...rest) => {
  const value = rest.pop();
  const keys = Object.keys(object)

  for (let key of keys) {
    if (object[key] === value) return key;
  }
  return undefined;
};

require('../Tests/find.js')(find);
