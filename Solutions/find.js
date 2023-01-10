// Find key by value

'use strict';

const find = (object, ...rest) => {
  const value = rest[0];
  const keys = Object.keys(object);
  for (const key of  keys) {
    if (object[key] === value) {
      if (key) return key;
    }
  }
  return undefined;
};

require('../Tests/find.js')(find);
