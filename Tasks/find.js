// Find key by value

 find = (object, ...rest) => {
  const value = rest.pop(1);
  const objects = Object.keys(object);
  for ( name of objects) {
    if (object[name] === value) return name;
    }
  return undefined;
};

require('../Tests/find.js')(find);
