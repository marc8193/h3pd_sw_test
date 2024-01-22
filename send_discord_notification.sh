#!/bin/bash

# Generalized Discord Notification Script

discord_url="https://discord.com/api/webhooks/1198863925962346556/NO6Wor_A5Delf0qbfwxN-ufVOpe86Wb1T8rBSeps7h276qls7OUivJ5VY3cHrNvUCDnl"

# Define a function to send a message
send_discord_notification() {
  local message=$1
  
  # Construct payload
  local payload=$(cat <<EOF
{
  "content": "$message"
}
EOF
)

  # Send POST request to Discord Webhook
  curl -H "Content-Type: application/json" -X POST -d "$payload" $discord_url
}

# Use the function
send_discord_notification "$*"
