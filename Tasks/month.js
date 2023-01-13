// Get month number

Months = [
  'jan',
  'feb',
  'mar',
  'apr',
  'may',
  'jun',
  'jul',
  'aug',
  'sep',
  'oct',
  'nov',
  'dec',
];

Month = (s) => {
  return Months.indexOf(s.toLowerCase().substring(0, 3)) !== -1 ? Months.indexOf(s.toLowerCase().substring(0, 3)) + 1 : -1;
};

require('../Tests/month.js')(Month);
