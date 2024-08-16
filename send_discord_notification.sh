#!/bin/bash

# Generalized Discord Notification Script

discord_url="https://discord.com/api/webhooks/1198863925962346556/$2"

discord_msg=$2

# Define a function to send a message
send_discord_notification() {
  
  # Construct payload
  local payload=$(cat <<EOF
{
  "content": "$discord_msg"
}
EOF
)

  # Send POST request to Discord Webhook
  curl -H "Content-Type: application/json" -X POST -d "$payload" $discord_url
}

# Use the function
send_discord_notification "$*"
