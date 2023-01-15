// Find key by value

const find = (object, ...rest) => {
  const value = rest.pop();
  const name = Object.keys(object);
  for (const key of name) {
    if (object[key] === value) 
    return key;
  }
  return undefined;
};

require('../Tests/find.js')(find);
