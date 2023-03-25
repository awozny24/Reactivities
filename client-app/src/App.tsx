import axios from 'axios';
import React, { useEffect, useState } from 'react';
import './App.css';
import logo from './logo.svg'
import {Header, List, Button} from 'semantic-ui-react';

function App() {

  const [activities, setActivities] = useState([]);
  
  useEffect(() => {   
    axios.get("http://localhost:5000/api/activities")
      .then(response => {
        setActivities(response.data);
      })
  }, [])

  return (
    <div>
        <Header as='h2' icon='users' content='Reactivities'/>
        <List>
            {activities.map((activity : any) => (
              <List.Item key={activity.id}>{activity.title}
              </List.Item>
            ))}
        </List>
        <Button content='test'></Button>
    </div>
  );
}

export default App;