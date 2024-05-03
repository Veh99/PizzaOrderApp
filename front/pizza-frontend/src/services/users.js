export async function getAllUsers() {
    const response = await fetch("http://localhost:5119/User");
    return response.json();
}

