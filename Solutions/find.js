// Find key by value

'use strict';

const find = (object, ...rest) => {
  const value = rest[0];
  for (const name in object) {
    if (object[name] === value) {
      if (name) return name;
    }
  }
  return undefined;
};

require('../Tests/find.js')(find);
