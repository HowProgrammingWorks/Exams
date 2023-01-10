// Find key by value

'use strict';

const find = (object, ...rest) => {
  const value = rest.pop();
  for (const name in object) {
    if (object[name] === value) {
      if (typeof name) return name;
    }
  }
  return undefined;
};

require('../Tests/find.js')(find);
