// Filter array by type name

Filter = (T, t) => {
  for (C of T) {
    x = T.indexOf(C);
    if (typeof T[x] !== t) {
      T.splice(x, 1);
    }
  }
  return T;
};

require('../Tests/filter.js')(Filter);
