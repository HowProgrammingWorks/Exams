// Find key by value

find = (object, ...rest) => {
  return Object.keys(object).find((key) =>
    object[key] === rest[0]);
  
  return undefined;
};

require('../Tests/find.js')(find);
