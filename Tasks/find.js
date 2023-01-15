// Find key by value
'use strict';

const find = (object, ...rest) => {
  const value = rest.pop();
  for (name in object) {
    if (object[name] !== value) {
    } else {
      if (typeof name) return name;
      if (typeof object) return object;
    }
  }
  return undefined;
};

require('../Tests/find.js')(find);
