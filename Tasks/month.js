// Get month number

const months = ['jan','feb','mar','apr','may','jun','jul','aug','sep','oct','nov','dec'];

const findMonth = month => {
  l = Months.length;
  for (let i = 0; i < l; i++) {
    if (s.toLowerCase().startsWith(Months[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(Month);
