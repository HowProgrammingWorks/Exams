// Find key by value

find = (object, ...rest) => {
  let value = rest.pop();
  for (key in object) {
    if (object[key] !== value) {
    } else {
      if (typeof key) return key;
      if (typeof object) return object;
    }
  }
  return undefined;
};

require('../Tests/find.js')(find);
