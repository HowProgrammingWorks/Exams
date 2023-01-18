// Get day number

//Step 1
//Change `let` into `const`
//Move `let i` into `for`
//Remove useless brackets

const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

_parse_day_ = (s) => {
  for (let i = 0; i < D.length; i++) {
    if (s.startsWith(D[i].toLowerCase())) 
      return i + 1;
  }
  return -1;
};

require('../Tests/day.js')(_parse_day_);
