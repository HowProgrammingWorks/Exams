// Find key by value
'use strict';

const find = (object, ...rest) => {
  const value = rest.pop();
  for (name in object) {
    if (object[name] === value) return name;
  }
  return undefined;
};

require('../Tests/find.js')(find);
