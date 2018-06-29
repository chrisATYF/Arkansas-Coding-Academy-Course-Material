// Create a new object of a Hospital
class Hospital {
    constructor(employees) {
        this._employees = employees;
    }
    get employees() {
        return this._employees;
    }
    set employees(employees) {
        this._employees = employees;
    }
}

// Create a new object of a Surgeon
class Surgeon extends Hospital {
    constructor(name, department, vacationDays, nurses) {
        super();
        this._name = name;
        this._department = department;
        this._vacationDays = vacationDays;
        this._nurses = nurses;
    }
    get name() {
        return this._name;
    }
    set name(name) {
        this._name = name;
    }
    get department() {
        return this._department;
    }
    set department(department) {
        this._department = department;
    }
    get vacationDays() {
        return this._vacationDays;
    }
    set vacationDays(vacationDays) {
        this._vacationDays = vacationDays;
    }
    get nurses() {
        return this._nurses;
    }
    set nurses(nurses) {
        this._nurses = nurses;
    }

    timeOffRequest(daysOff) {
        if (this.vacationDays != 0) {
            var totalTimeCharged = Math.round(daysOff / 2);
            this._vacationDays = this._vacationDays - totalTimeCharged;
            console.log('Time requested: ' + daysOff + ', Time charged: ' + totalTimeCharged);
        } else {
            console.log("You don't have enough vacation time saved");
        }
        return this._vacationDays
    }
}

// Create a new object of a Nurse
class Nurse extends Hospital {
    constructor(name, certifications, vacationDays, patients) {
        super();
        this._name = name;
        this._certifications = [];
        for (var i = 0; i < certifications.length; i++) {
            if (this._certifications.length == 0) {
                this._certifications.push(certifications[i]);
            } else {
                for (var j = 0; j < this._certifications.length; j++) {
                    if (this._certifications[j] != certifications[i]) {
                        this._certifications.push(certifications[i]);
                    }
                }
            }
        }
        this._vacationDays = vacationDays;
        this._patients = patients;
    }
    get name() {
        return this._name;
    }
    set name(name) {
        this.name = _name;
    }
    get certifications() {
        return this._certifications;
    }
    set certifications(certifications) {
        this._certifications = certifications;
    }
    get vacationDays() {
        return this._vacationDays;
    }
    set vacationDays(vacationDays) {
        if (this.vacationDays != 0) {
            this._vacationDays = vacationDays;
        } else {
            console.log("You don't have enough vacation time saved");
        }
        this._vacationDays = vacationDays;
    }
    get patients() {
        return this._patients;
    }
    set patients(patients) {
        this._patients = patients;
    }

    timeOffRequest(daysOff) {
        this._vacationDays = this._vacationDays - daysOff;
    }
}

// Create a new object of a Patient
class Patient {
    constructor(name, patientID) {
        this._name = name;
        this._patientID = patientID;
    }
    get name() {
        return this._name;
    }
    set name(name) {
        this._name = name;
    }
    get patientID() {
        return this._patientID;
    }
}

// Create a new instance of a Hospital
var springHillBaptist = new Hospital(['Joey', 'Martha', 'Charlie', 'Sarah']);

// Create a new instance of a Surgeon
var joey = new Surgeon('Joey', 'Neurologist', 20, ['Martha', 'Charlie']);
var sarah = new Surgeon('Sarah', 'Cardiovascular', 20);

// Create a new instance of a Nurse
var martha = new Nurse('Martha', ['CPR', 'First-Aid', 'C-EFM'], 15, ['Chris', 1001]);
var charlie = new Nurse('Charlie', ['APHN-BC', 'CHPPN', 'OCN'], 15, ['Rusty', 1003]);
var stuart = new Nurse('Stuart', ['CPR', 'Getting the vein on the first try', 'CHPPN'], 15, ['Bob', 1002]);
var little = new Nurse('Little', ['APHN-BC', 'OCN', 'C-EFM'], 15, ['Wilhelm', 1004]);

// Create a new instance of a Patient
var chris = new Patient('Chris', 1001);
var bob = new Patient('Bob', 1002);
var rusty = new Patient('Rusty', 1003);
var wilhelm = new Patient('Wilhelm', 1004);

console.log(little.certifications);