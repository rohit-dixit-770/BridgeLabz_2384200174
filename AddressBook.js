class Contact {
    constructor(firstName, lastName, address, city, state, zip, phone, email) {
        const nameRegex = /^[A-Z][a-z]{2,}$/;
        const addressRegex = /^[A-Za-z0-9\s]{4,}$/;
        const zipRegex = /^[0-9]{6}$/;
        const phoneRegex = /^[0-9]{10}$/;
        const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

        if (!nameRegex.test(firstName) || !nameRegex.test(lastName)) {
            throw new Error("First and Last Name should start with a capital letter and have at least 3 characters.");
        }
        if (!addressRegex.test(address) || !addressRegex.test(city) || !addressRegex.test(state)) {
            throw new Error("Address, City, and State must have at least 4 characters.");
        }
        if (!zipRegex.test(zip)) {
            throw new Error("Invalid Zip Code.");
        }
        if (!phoneRegex.test(phone)) {
            throw new Error("Phone number must be 10 digits.");
        }
        if (!emailRegex.test(email)) {
            throw new Error("Invalid Email Format.");
        }

        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phone = phone;
        this.email = email;
    }

    toString() {
        return `Name: ${this.firstName} ${this.lastName}, Address: ${this.address}, ${this.city}, ${this.state} - ${this.zip}, Phone: ${this.phone}, Email: ${this.email}`;
    }
}

class AddressBook {
    constructor() {
        this.contacts = [];
    }

    addContact(contact) {
        if (this.contacts.some(c => c.firstName === contact.firstName && c.lastName === contact.lastName)) {
            console.log("Duplicate entry detected. Contact not added.");
            return;
        }
        this.contacts.push(contact);
        console.log("Contact added successfully.");
    }

    displayContacts() {
        if (this.contacts.length === 0) {
            console.log("No contacts in Address Book.");
        } else {
            this.contacts.forEach(contact => console.log(contact.toString()));
        }
    }

    findContact(name) {
        return this.contacts.find(contact => contact.firstName === name || contact.lastName === name);
    }

    editContact(name, newDetails) {
        let contact = this.findContact(name);
        if (contact) {
            Object.assign(contact, newDetails);
            console.log("Contact updated successfully.");
        } else {
            console.log("Contact not found.");
        }
    }

    deleteContact(name) {
        let index = this.contacts.findIndex(contact => contact.firstName === name || contact.lastName === name);
        if (index !== -1) {
            this.contacts.splice(index, 1);
            console.log("Contact deleted successfully.");
        } else {
            console.log("Contact not found.");
        }
    }

    countContacts() {
        return this.contacts.reduce(count => count + 1, 0);
    }

    searchByCity(city) {
        return this.contacts.filter(contact => contact.city === city);
    }

    searchByState(state) {
        return this.contacts.filter(contact => contact.state === state);
    }

    viewContactsByCity(city) {
        let results = this.searchByCity(city);
        results.length > 0 ? results.forEach(c => console.log(c.toString())) : console.log("No contacts found in this city.");
    }

    viewContactsByState(state) {
        let results = this.searchByState(state);
        results.length > 0 ? results.forEach(c => console.log(c.toString())) : console.log("No contacts found in this state.");
    }

    countByCity() {
        return this.contacts.reduce((acc, contact) => {
            acc[contact.city] = (acc[contact.city] || 0) + 1;
            return acc;
        }, {});
    }

    countByState() {
        return this.contacts.reduce((acc, contact) => {
            acc[contact.state] = (acc[contact.state] || 0) + 1;
            return acc;
        }, {});
    }

    sortByName() {
        this.contacts.sort((a, b) => a.firstName.localeCompare(b.firstName));
    }

    sortByCity() {
        this.contacts.sort((a, b) => a.city.localeCompare(b.city));
    }

    sortByState() {
        this.contacts.sort((a, b) => a.state.localeCompare(b.state));
    }

    sortByZip() {
        this.contacts.sort((a, b) => a.zip.localeCompare(b.zip));
    }
}

// Example Usage
try {
    let addressBook = new AddressBook();

    let contact1 = new Contact("Rohit", "Dixit", "Shahjahanpur", "Shahjahanpur", "Uttar Pradesh", "242001", "1234567890", "rohit@gmail.com");
    let contact2 = new Contact("Ankit", "Singh", "Mathura", "Mathura", "Uttar Pradesh", "281406", "9876543210", "ankit@gmail.com");
    let contact3 = new Contact("Mohit", "Dixit", "Mathura", "Mathura", "Uttar Pradesh", "281406", "5555555555", "rohit@gmail.com");

    addressBook.addContact(contact1);
    addressBook.addContact(contact2);
    addressBook.addContact(contact3);

    console.log("\n All Contacts:");
    addressBook.displayContacts();

    console.log("\n Finding Contact 'Rohit':");
    console.log(addressBook.findContact("Rohit"));

    console.log("\n Editing 'Rohit' - Changing Phone Number:");
    addressBook.editContact("Rohit", { phone: "1112223333" });
    addressBook.displayContacts();

    console.log("\n Deleting Contact 'Rohit':");
    addressBook.deleteContact("Rohit");
    addressBook.displayContacts();

    console.log("\n Total Contacts:", addressBook.countContacts());

    console.log("\n Viewing Contacts by City 'Shahjahanpur':");
    addressBook.viewContactsByCity("Shahjahanpur");

    console.log("\n Viewing Contacts by State 'Shahjahanpur':");
    addressBook.viewContactsByState("Shahjahanpur");

    console.log("\n Counting Contacts by City:");
    console.log(addressBook.countByCity());

    console.log("\n Counting Contacts by State:");
    console.log(addressBook.countByState());

    console.log("\n Sorting Contacts by Name:");
    addressBook.sortByName();
    addressBook.displayContacts();

    console.log("\n Sorting Contacts by City:");
    addressBook.sortByCity();
    addressBook.displayContacts();

    console.log("\n Sorting Contacts by State:");
    addressBook.sortByState();
    addressBook.displayContacts();

    console.log("\n Sorting Contacts by Zip:");
    addressBook.sortByZip();
    addressBook.displayContacts();
} catch (error) {
    console.log(" Error:", error.message);
}
export { Contact, AddressBook };