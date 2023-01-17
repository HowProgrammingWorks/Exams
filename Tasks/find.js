// Find key by value

find = (object, ...rest) => {
  let value = rest.pop();
  for (key in object) {
    if (object[key] === value) {
      return key;
    } 
  }
  return undefined;
};

require('../Tests/find.js')(find);
