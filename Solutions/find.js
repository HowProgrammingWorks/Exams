// Find key by value

find = (object, ...rest) => {
  value = rest.pop();
  for (name in object) {
    if (object[name] === value) return name;
  }
  return undefined;
};

require('../Tests/find.js')(find);
