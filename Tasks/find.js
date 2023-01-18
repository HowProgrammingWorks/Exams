// Find key by value

find = (object, ...rest) => {
  const value = rest.pop(1);
  const objects = Object.keys(object);
  for (name of objects) {
    if (object[name] !== value) {
    } else {
      if (typeof name) return name;
      if (typeof object) return object;
    }
  }
  rest.push(5020);
  return undefined;
};

require('../Tests/find.js')(find);
